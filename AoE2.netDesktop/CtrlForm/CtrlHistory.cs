﻿namespace AoE2NetDesktop.CtrlForm;

using AoE2NetDesktop.AoE2DE;
using AoE2NetDesktop.Form;
using AoE2NetDesktop.LibAoE2Net.Functions;
using AoE2NetDesktop.LibAoE2Net.JsonFormat;
using AoE2NetDesktop.LibAoE2Net.Parameters;
using AoE2NetDesktop.Utility.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// FormHistory controler.
/// </summary>
public class CtrlHistory : FormControler
{
    private const int ReadCountMax = 1000;
    private static readonly Dictionary<string, LeaderboardId> LeaderboardNameList = new() {
        { "1v1 Random Map", LeaderboardId.RM1v1 },
        { "Team Random Map", LeaderboardId.RMTeam },
        { "1v1 Empire Wars", LeaderboardId.EW1v1 },
        { "Team Empire Wars", LeaderboardId.EWTeam },
        { "Unranked", LeaderboardId.Unranked },
        { "1v1 Death Match", LeaderboardId.DM1v1 },
        { "Team Death Match", LeaderboardId.DMTeam },
    };

    private static readonly Dictionary<string, DataSource> DataSourceNameList = new() {
        { "Map", DataSource.Map },
        { "Civilization", DataSource.Civilization },
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="CtrlHistory"/> class.
    /// </summary>
    /// <param name="profileId">Profile ID.</param>
    public CtrlHistory(int profileId)
    {
        ProfileId = profileId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CtrlHistory"/> class.
    /// </summary>
    /// <param name="profileId">Profile ID.</param>
    /// <param name="matches">Player match history.</param>
    public CtrlHistory(int profileId, PlayerMatchHistory matches)
    {
        ProfileId = profileId;
        PlayerMatchHistory = matches;
    }

    /// <summary>
    /// Gets playerMatchHistory.
    /// </summary>
    public PlayerMatchHistory PlayerMatchHistory { get; private set; } = new();

    /// <summary>
    /// Gets or sets leaderboard List.
    /// </summary>
    public Dictionary<LeaderboardId, Leaderboard> Leaderboards { get; set; } = new();

    /// <summary>
    /// Gets profile ID.
    /// </summary>
    public int ProfileId { get; }

    /// <summary>
    /// Gets matched Player Infos.
    /// </summary>
    public Dictionary<string, PlayerInfo> MatchedPlayerInfos { get; private set; } = new();

    /// <summary>
    /// Get leaderboard string.
    /// </summary>
    /// <returns>
    /// rate value and rating change value.
    /// </returns>
    public static string[] GetLeaderboardStrings()
    {
        return LeaderboardNameList.Keys.ToArray();
    }

    /// <summary>
    /// Get leaderboard string.
    /// </summary>
    /// <returns>
    /// rate value and rating change value.
    /// </returns>
    public static string[] GetDataSourceStrings()
    {
        return DataSourceNameList.Keys.ToArray();
    }

    /// <summary>
    /// Get leaderboard string.
    /// </summary>
    /// <param name="dataNameString">string of data source name.</param>
    /// <returns>DataSource.</returns>
    public static DataSource GetDataSource(string dataNameString)
    {
        var result = DataSourceNameList.TryGetValue(dataNameString, out DataSource ret);
        if(!result) {
            ret = DataSource.Undefined;
        }

        return ret;
    }

    /// <summary>
    /// Get leaderboard ID from string.
    /// </summary>
    /// <param name="leaderboardString">string of leaderboard ID.</param>
    /// <returns>LeaderBoardId.</returns>
    public static LeaderboardId GetLeaderboardId(string leaderboardString)
    {
        LeaderboardId ret;

        if(leaderboardString != null) {
            if(!LeaderboardNameList.TryGetValue(leaderboardString, out ret)) {
                ret = LeaderboardId.Undefined;
            }
        } else {
            ret = LeaderboardId.Undefined;
        }

        return ret;
    }

    /// <summary>
    /// Show History.
    /// </summary>
    /// <param name="playerName">player name.</param>
    /// <param name="profileId">profile ID.</param>
    /// <returns>FormHistory Instance.</returns>
    public static FormHistory GenerateFormHistory(string playerName, int? profileId)
    {
        FormHistory ret = null;

        if(profileId is int id) {
            ret = new FormHistory(id) {
                Text = $"{playerName}'s history - AoE2.net Desktop",
            };
        }

        return ret;
    }

    /// <summary>
    /// Create ListViewItem of leaderboard.
    /// </summary>
    /// <param name="leaderboardName">Leaderboard name.</param>
    /// <param name="leaderboardId">Leaderboard ID.</param>
    /// <param name="leaderboards">Leaderboard data.</param>
    /// <param name="leaderboardColor">Leaderboard Color.</param>
    /// <returns>ListViewItem for leaderboard.</returns>
    public static ListViewItem CreateListViewItem(
        string leaderboardName,
        LeaderboardId leaderboardId,
        Dictionary<LeaderboardId, Leaderboard> leaderboards,
        Dictionary<LeaderboardId, Color> leaderboardColor)
    {
        var leaderboard = leaderboards[leaderboardId];
        var ret = new ListViewItem(leaderboardName) {
            Tag = leaderboardId,
            ForeColor = leaderboardColor[leaderboardId],
            Checked = true,
        };

        ret.Font = new Font(ret.Font, FontStyle.Bold);
        ret.SubItems.Add(leaderboard.RankToString());
        ret.SubItems.Add(leaderboard.RatingToString());
        ret.SubItems.Add(leaderboard.HighestRatingToString());
        ret.SubItems.Add(leaderboard.GamesToString());
        ret.SubItems.Add(leaderboard.WinRateToString());
        ret.SubItems.Add(leaderboard.WinsToString());
        ret.SubItems.Add(leaderboard.LossesToString());
        ret.SubItems.Add(leaderboard.DropsToString());
        ret.SubItems.Add(leaderboard.StreakToString());
        ret.SubItems.Add(leaderboard.HighestStreakToString());
        ret.SubItems.Add(leaderboard.LowestStreakToString());

        return ret;
    }

    /// <summary>
    /// Create listView of PlayerMatchHistory.
    /// </summary>
    /// <returns>LeaderBoardId collections.</returns>
    public Dictionary<LeaderboardId, List<ListViewItem>> CreateListViewHistory()
    {
        var ret = new Dictionary<LeaderboardId, List<ListViewItem>> {
            { LeaderboardId.Unranked, new List<ListViewItem>() },
            { LeaderboardId.DM1v1, new List<ListViewItem>() },
            { LeaderboardId.DMTeam, new List<ListViewItem>() },
            { LeaderboardId.RM1v1, new List<ListViewItem>() },
            { LeaderboardId.RMTeam, new List<ListViewItem>() },
            { LeaderboardId.EW1v1, new List<ListViewItem>() },
            { LeaderboardId.EWTeam, new List<ListViewItem>() },
        };

        foreach(var match in PlayerMatchHistory) {
            var player = match.GetPlayer(ProfileId);
            var listViewItem = new ListViewItem(match.GetMapName());
            listViewItem.SubItems.Add(player.GetRatingString());
            listViewItem.SubItems.Add(player.GetWinMarkerString());
            listViewItem.SubItems.Add(player.GetCivName());
            listViewItem.SubItems.Add(player.GetColorString());
            listViewItem.SubItems.Add(match.GetOpenedTime().ToString());
            listViewItem.SubItems.Add(match.Version);

            if(match.LeaderboardId != null) {
                var leaderboardId = (LeaderboardId)match.LeaderboardId;
                ret[leaderboardId].Add(listViewItem);
            }
        }

        return ret;
    }

    /// <summary>
    /// Create MatchedPlayers info.
    /// The player's rating is the rating when they played with you.
    /// </summary>
    /// <param name="matches">Player match history.</param>
    /// <returns>Matched players info.</returns>
    public Dictionary<string, PlayerInfo> CreateMatchedPlayersInfo(PlayerMatchHistory matches)
    {
        var players = new Dictionary<string, PlayerInfo>();

        foreach(var match in matches) {
            var selectedPlayer = match.GetPlayer(ProfileId);
            foreach(var player in match.Players.Where(player => player != selectedPlayer)) {
                var name = player.Name ?? $"<Name null: ID: {player.ProfilId} >";
                if(!players.ContainsKey(name)) {
                    players.Add(name, new PlayerInfo());
                }

                GetplayerInfo(match, player, selectedPlayer.CheckDiplomacy(player), players[name]);
            }
        }

        MatchedPlayerInfos = players;

        return players;
    }

    /// <summary>
    /// Open player's profile on AoE2.net.
    /// </summary>
    /// <param name="playerName">player name.</param>
    public void OpenProfile(string playerName)
    {
        if(MatchedPlayerInfos.TryGetValue(playerName, out PlayerInfo playerInfo)) {
            try {
                AoE2net.OpenAoE2net((int)playerInfo.ProfileId);
            } catch(Win32Exception noBrowser) {
                Debug.Print(noBrowser.Message);
            } catch(Exception other) {
                Debug.Print(other.Message);
            }
        } else {
            Debug.Print($"Unavailable Player Name: {playerName}.");
        }
    }

    /// <summary>
    /// Open player's History on new History window.
    /// </summary>
    /// <param name="playerName">player name.</param>
    /// <returns>Instance of FormHistory.</returns>
    public FormHistory GenerateFormHistory(string playerName)
    {
        FormHistory ret = null;

        if(MatchedPlayerInfos.TryGetValue(playerName, out PlayerInfo playerInfo)) {
            ret = GenerateFormHistory(playerName, playerInfo.ProfileId);
        } else {
            Debug.Print($"Unavailable Player Name: {playerName}.");
        }

        return ret;
    }

    /// <summary>
    /// Read player match history from AoE2.net.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task<bool> ReadPlayerMatchHistoryAsync()
    {
        bool ret;

        try {
            PlayerMatchHistory readPlayerMatchHistory;
            PlayerMatchHistory.Clear();

            do {
                var startCount = PlayerMatchHistory.Count;
                readPlayerMatchHistory = await AoE2net.GetPlayerMatchHistoryAsync(startCount, ReadCountMax, ProfileId);
                PlayerMatchHistory.AddRange(readPlayerMatchHistory);
            } while(readPlayerMatchHistory.Count == ReadCountMax);

            MatchedPlayerInfos = CreateMatchedPlayersInfo(PlayerMatchHistory);
            ret = true;
        } catch(Exception) {
            PlayerMatchHistory = null;
            MatchedPlayerInfos = null;
            ret = false;
        }

        return ret;
    }

    /// <summary>
    /// Read player LeaderBoard from AoE2.net.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task<Dictionary<LeaderboardId, Leaderboard>> ReadLeaderBoardAsync()
    {
        try {
            var containers = new List<LeaderboardContainer>() {
                await GetLeaderboardAsync(LeaderboardId.RM1v1),
                await GetLeaderboardAsync(LeaderboardId.DM1v1),
                await GetLeaderboardAsync(LeaderboardId.EW1v1),
                await GetLeaderboardAsync(LeaderboardId.RMTeam),
                await GetLeaderboardAsync(LeaderboardId.DMTeam),
                await GetLeaderboardAsync(LeaderboardId.EWTeam),
                await GetLeaderboardAsync(LeaderboardId.Unranked),
            };
            Leaderboards = new Dictionary<LeaderboardId, Leaderboard> {
                { LeaderboardId.RM1v1, containers[0].Leaderboards[0] },
                { LeaderboardId.DM1v1, containers[1].Leaderboards[0] },
                { LeaderboardId.EW1v1, containers[2].Leaderboards[0] },
                { LeaderboardId.RMTeam, containers[3].Leaderboards[0] },
                { LeaderboardId.DMTeam, containers[4].Leaderboards[0] },
                { LeaderboardId.EWTeam, containers[5].Leaderboards[0] },
                { LeaderboardId.Unranked, containers[6].Leaderboards[0] },
            };
        } catch(Exception e) {
            Debug.Print($"GetLeaderboardAsync Error{e.Message}: {e.StackTrace}");
        }

        return Leaderboards;
    }

    private static void GetplayerInfo(Match match, Player player, Diplomacy diplomacy, PlayerInfo playerInfo)
    {
        playerInfo.Country = CountryCode.ConvertToFullName(player.Country);
        playerInfo.ProfileId = player.ProfilId;

        switch(match.LeaderboardId) {
        case LeaderboardId.RM1v1:
            playerInfo.RateRM1v1 = player.Rating;
            playerInfo.Games1v1++;
            break;
        case LeaderboardId.RMTeam:
            playerInfo.RateRMTeam = player.Rating;
            playerInfo.GamesTeam++;

            switch(diplomacy) {
            case Diplomacy.Ally:
                playerInfo.GamesAlly++;
                break;
            case Diplomacy.Enemy:
                playerInfo.GamesEnemy++;
                break;
            }

            break;
        }

        playerInfo.LastDate = match.GetOpenedTime();
    }

    private async Task<LeaderboardContainer> GetLeaderboardAsync(LeaderboardId leaderBoardId)
    {
        var ret = await AoE2net.GetLeaderboardAsync(leaderBoardId, 0, 1, ProfileId);

        if(ret.Leaderboards.Count == 0) {
            var ratings = await AoE2net.GetPlayerRatingHistoryAsync(ProfileId, leaderBoardId, 1);
            var leaderboard = new Leaderboard();
            if(ratings.Count != 0) {
                leaderboard.Rating = ratings[0].Rating;
                leaderboard.Games = ratings[0].NumWins + ratings[0].NumLosses;
                leaderboard.Wins = ratings[0].NumWins;
                leaderboard.Losses = ratings[0].NumLosses;
            }

            ret.Leaderboards.Add(leaderboard);
        }

        return ret;
    }
}
