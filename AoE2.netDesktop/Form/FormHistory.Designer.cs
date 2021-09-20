﻿
namespace AoE2NetDesktop.Form
{
    partial class FormHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripMatchedPlayers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAoE2NetProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageMatches = new System.Windows.Forms.TabPage();
            this.labelComboBoxLeaderboard = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.listViewMatchHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.labelDataSource = new System.Windows.Forms.Label();
            this.comboBoxDataSource = new System.Windows.Forms.ComboBox();
            this.formsPlotWinRate = new ScottPlot.FormsPlot();
            this.comboBoxLeaderboard = new System.Windows.Forms.ComboBox();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.splitContainerRate = new System.Windows.Forms.SplitContainer();
            this.formsPlotRate1v1 = new ScottPlot.FormsPlot();
            this.formsPlotRateTeam = new ScottPlot.FormsPlot();
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.columnHeaderLeaderboard = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRank = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRating = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderHighestRating = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderGames = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderWinRate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderWins = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLosses = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDrop = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStreak = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderHighestStreak = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLowestStreak = new System.Windows.Forms.ColumnHeader();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listViewMatchedPlayers = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCountry = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRate1v1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRateTeam = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTeamGameCount = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAllyGames = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEnemyGames = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1v1GameCount = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastDate = new System.Windows.Forms.ColumnHeader();
            this.formsPlotCountry = new ScottPlot.FormsPlot();
            this.tabControlHistory = new System.Windows.Forms.TabControl();
            this.contextMenuStripMatchedPlayers.SuspendLayout();
            this.tabPageMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRate)).BeginInit();
            this.splitContainerRate.Panel1.SuspendLayout();
            this.splitContainerRate.Panel2.SuspendLayout();
            this.splitContainerRate.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripMatchedPlayers
            // 
            this.contextMenuStripMatchedPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAoE2NetProfileToolStripMenuItem});
            this.contextMenuStripMatchedPlayers.Name = "contextMenuStripMatchedPlayers";
            this.contextMenuStripMatchedPlayers.Size = new System.Drawing.Size(200, 26);
            this.contextMenuStripMatchedPlayers.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripMatchedPlayers_Opening);
            // 
            // openAoE2NetProfileToolStripMenuItem
            // 
            this.openAoE2NetProfileToolStripMenuItem.Name = "openAoE2NetProfileToolStripMenuItem";
            this.openAoE2NetProfileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openAoE2NetProfileToolStripMenuItem.Text = "Open AoE2.net profile...";
            this.openAoE2NetProfileToolStripMenuItem.Click += new System.EventHandler(this.OpenAoE2NetProfileToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageMatches
            // 
            this.tabPageMatches.Controls.Add(this.labelComboBoxLeaderboard);
            this.tabPageMatches.Controls.Add(this.splitContainer5);
            this.tabPageMatches.Controls.Add(this.comboBoxLeaderboard);
            this.tabPageMatches.Location = new System.Drawing.Point(4, 24);
            this.tabPageMatches.Name = "tabPageMatches";
            this.tabPageMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatches.Size = new System.Drawing.Size(1000, 573);
            this.tabPageMatches.TabIndex = 5;
            this.tabPageMatches.Text = "Matches";
            this.tabPageMatches.UseVisualStyleBackColor = true;
            // 
            // labelComboBoxLeaderboard
            // 
            this.labelComboBoxLeaderboard.AutoSize = true;
            this.labelComboBoxLeaderboard.Location = new System.Drawing.Point(8, 13);
            this.labelComboBoxLeaderboard.Name = "labelComboBoxLeaderboard";
            this.labelComboBoxLeaderboard.Size = new System.Drawing.Size(73, 15);
            this.labelComboBoxLeaderboard.TabIndex = 9;
            this.labelComboBoxLeaderboard.Text = "Leaderboard";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Location = new System.Drawing.Point(3, 43);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.listViewMatchHistory);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.labelDataSource);
            this.splitContainer5.Panel2.Controls.Add(this.comboBoxDataSource);
            this.splitContainer5.Panel2.Controls.Add(this.formsPlotWinRate);
            this.splitContainer5.Size = new System.Drawing.Size(994, 527);
            this.splitContainer5.SplitterDistance = 438;
            this.splitContainer5.TabIndex = 8;
            // 
            // listViewMatchHistory
            // 
            this.listViewMatchHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMatchHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewMatchHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMatchHistory.FullRowSelect = true;
            this.listViewMatchHistory.GridLines = true;
            this.listViewMatchHistory.HideSelection = false;
            this.listViewMatchHistory.Location = new System.Drawing.Point(0, 0);
            this.listViewMatchHistory.Name = "listViewMatchHistory";
            this.listViewMatchHistory.Size = new System.Drawing.Size(434, 523);
            this.listViewMatchHistory.TabIndex = 0;
            this.listViewMatchHistory.UseCompatibleStateImageBehavior = false;
            this.listViewMatchHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Map";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Win";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Civilization";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Color";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Version";
            // 
            // labelDataSource
            // 
            this.labelDataSource.AutoSize = true;
            this.labelDataSource.Location = new System.Drawing.Point(13, 15);
            this.labelDataSource.Name = "labelDataSource";
            this.labelDataSource.Size = new System.Drawing.Size(69, 15);
            this.labelDataSource.TabIndex = 10;
            this.labelDataSource.Text = "Data source";
            // 
            // comboBoxDataSource
            // 
            this.comboBoxDataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataSource.Enabled = false;
            this.comboBoxDataSource.FormattingEnabled = true;
            this.comboBoxDataSource.Location = new System.Drawing.Point(92, 12);
            this.comboBoxDataSource.Name = "comboBoxDataSource";
            this.comboBoxDataSource.Size = new System.Drawing.Size(89, 23);
            this.comboBoxDataSource.TabIndex = 7;
            this.comboBoxDataSource.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDataSource_SelectedIndexChanged);
            // 
            // formsPlotWinRate
            // 
            this.formsPlotWinRate.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotWinRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotWinRate.Location = new System.Drawing.Point(0, 0);
            this.formsPlotWinRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotWinRate.Name = "formsPlotWinRate";
            this.formsPlotWinRate.Size = new System.Drawing.Size(548, 523);
            this.formsPlotWinRate.TabIndex = 6;
            // 
            // comboBoxLeaderboard
            // 
            this.comboBoxLeaderboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaderboard.Enabled = false;
            this.comboBoxLeaderboard.FormattingEnabled = true;
            this.comboBoxLeaderboard.Location = new System.Drawing.Point(87, 10);
            this.comboBoxLeaderboard.Name = "comboBoxLeaderboard";
            this.comboBoxLeaderboard.Size = new System.Drawing.Size(128, 23);
            this.comboBoxLeaderboard.TabIndex = 8;
            this.comboBoxLeaderboard.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLeaderboard_SelectedIndexChanged);
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Controls.Add(this.splitContainerRate);
            this.tabPageStatistics.Controls.Add(this.listViewStatistics);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 24);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(1000, 573);
            this.tabPageStatistics.TabIndex = 1;
            this.tabPageStatistics.Text = "Statistics";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // splitContainerRate
            // 
            this.splitContainerRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRate.Location = new System.Drawing.Point(3, 193);
            this.splitContainerRate.Name = "splitContainerRate";
            this.splitContainerRate.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRate.Panel1
            // 
            this.splitContainerRate.Panel1.Controls.Add(this.formsPlotRate1v1);
            // 
            // splitContainerRate.Panel2
            // 
            this.splitContainerRate.Panel2.Controls.Add(this.formsPlotRateTeam);
            this.splitContainerRate.Size = new System.Drawing.Size(994, 377);
            this.splitContainerRate.SplitterDistance = 180;
            this.splitContainerRate.TabIndex = 5;
            // 
            // formsPlotRate1v1
            // 
            this.formsPlotRate1v1.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotRate1v1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotRate1v1.Location = new System.Drawing.Point(0, 0);
            this.formsPlotRate1v1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotRate1v1.Name = "formsPlotRate1v1";
            this.formsPlotRate1v1.Size = new System.Drawing.Size(992, 178);
            this.formsPlotRate1v1.TabIndex = 4;
            this.formsPlotRate1v1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormsPlotRate1v1_MouseMove);
            // 
            // formsPlotRateTeam
            // 
            this.formsPlotRateTeam.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotRateTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotRateTeam.Location = new System.Drawing.Point(0, 0);
            this.formsPlotRateTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotRateTeam.Name = "formsPlotRateTeam";
            this.formsPlotRateTeam.Size = new System.Drawing.Size(992, 191);
            this.formsPlotRateTeam.TabIndex = 3;
            this.formsPlotRateTeam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormsPlotRateTeam_MouseMove);
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLeaderboard,
            this.columnHeaderRank,
            this.columnHeaderRating,
            this.columnHeaderHighestRating,
            this.columnHeaderGames,
            this.columnHeaderWinRate,
            this.columnHeaderWins,
            this.columnHeaderLosses,
            this.columnHeaderDrop,
            this.columnHeaderStreak,
            this.columnHeaderHighestStreak,
            this.columnHeaderLowestStreak});
            this.listViewStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewStatistics.FullRowSelect = true;
            this.listViewStatistics.GridLines = true;
            this.listViewStatistics.HideSelection = false;
            this.listViewStatistics.Location = new System.Drawing.Point(3, 3);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(994, 190);
            this.listViewStatistics.TabIndex = 2;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLeaderboard
            // 
            this.columnHeaderLeaderboard.Text = "Leaderboard";
            this.columnHeaderLeaderboard.Width = 100;
            // 
            // columnHeaderRank
            // 
            this.columnHeaderRank.Text = "Rank";
            // 
            // columnHeaderRating
            // 
            this.columnHeaderRating.Text = "Rate";
            // 
            // columnHeaderHighestRating
            // 
            this.columnHeaderHighestRating.Text = "Highest Rating";
            this.columnHeaderHighestRating.Width = 100;
            // 
            // columnHeaderGames
            // 
            this.columnHeaderGames.Text = "Games";
            // 
            // columnHeaderWinRate
            // 
            this.columnHeaderWinRate.Text = "Win%";
            // 
            // columnHeaderWins
            // 
            this.columnHeaderWins.Text = "Wins";
            // 
            // columnHeaderLosses
            // 
            this.columnHeaderLosses.Text = "Losses";
            // 
            // columnHeaderDrop
            // 
            this.columnHeaderDrop.Text = "Drop";
            // 
            // columnHeaderStreak
            // 
            this.columnHeaderStreak.Text = "Streak";
            // 
            // columnHeaderHighestStreak
            // 
            this.columnHeaderHighestStreak.Text = "HighestStreak";
            this.columnHeaderHighestStreak.Width = 90;
            // 
            // columnHeaderLowestStreak
            // 
            this.columnHeaderLowestStreak.Text = "LowestStreak";
            this.columnHeaderLowestStreak.Width = 90;
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.Controls.Add(this.splitContainer2);
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 24);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(1000, 573);
            this.tabPagePlayers.TabIndex = 3;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewMatchedPlayers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.formsPlotCountry);
            this.splitContainer2.Size = new System.Drawing.Size(994, 567);
            this.splitContainer2.SplitterDistance = 514;
            this.splitContainer2.TabIndex = 9;
            // 
            // listViewMatchedPlayers
            // 
            this.listViewMatchedPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMatchedPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCountry,
            this.columnHeaderRate1v1,
            this.columnHeaderRateTeam,
            this.columnHeaderTeamGameCount,
            this.columnHeaderAllyGames,
            this.columnHeaderEnemyGames,
            this.columnHeader1v1GameCount,
            this.columnHeaderLastDate});
            this.listViewMatchedPlayers.ContextMenuStrip = this.contextMenuStripMatchedPlayers;
            this.listViewMatchedPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMatchedPlayers.FullRowSelect = true;
            this.listViewMatchedPlayers.GridLines = true;
            this.listViewMatchedPlayers.HideSelection = false;
            this.listViewMatchedPlayers.Location = new System.Drawing.Point(0, 0);
            this.listViewMatchedPlayers.Name = "listViewMatchedPlayers";
            this.listViewMatchedPlayers.Size = new System.Drawing.Size(510, 563);
            this.listViewMatchedPlayers.TabIndex = 2;
            this.listViewMatchedPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewMatchedPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 160;
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Text = "Country";
            // 
            // columnHeaderRate1v1
            // 
            this.columnHeaderRate1v1.Text = "1v1 Rate";
            // 
            // columnHeaderRateTeam
            // 
            this.columnHeaderRateTeam.Text = "Team Rate";
            this.columnHeaderRateTeam.Width = 70;
            // 
            // columnHeaderTeamGameCount
            // 
            this.columnHeaderTeamGameCount.Text = "Team Games";
            this.columnHeaderTeamGameCount.Width = 80;
            // 
            // columnHeaderAllyGames
            // 
            this.columnHeaderAllyGames.Text = "Ally";
            this.columnHeaderAllyGames.Width = 40;
            // 
            // columnHeaderEnemyGames
            // 
            this.columnHeaderEnemyGames.Text = "Enemy";
            // 
            // columnHeader1v1GameCount
            // 
            this.columnHeader1v1GameCount.Text = "1v1";
            this.columnHeader1v1GameCount.Width = 40;
            // 
            // columnHeaderLastDate
            // 
            this.columnHeaderLastDate.Text = "Last Date";
            this.columnHeaderLastDate.Width = 120;
            // 
            // formsPlotCountry
            // 
            this.formsPlotCountry.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formsPlotCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotCountry.Location = new System.Drawing.Point(0, 0);
            this.formsPlotCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotCountry.Name = "formsPlotCountry";
            this.formsPlotCountry.Size = new System.Drawing.Size(472, 563);
            this.formsPlotCountry.TabIndex = 8;
            // 
            // tabControlHistory
            // 
            this.tabControlHistory.Controls.Add(this.tabPageMatches);
            this.tabControlHistory.Controls.Add(this.tabPagePlayers);
            this.tabControlHistory.Controls.Add(this.tabPageStatistics);
            this.tabControlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHistory.Location = new System.Drawing.Point(0, 0);
            this.tabControlHistory.Name = "tabControlHistory";
            this.tabControlHistory.SelectedIndex = 0;
            this.tabControlHistory.Size = new System.Drawing.Size(1008, 601);
            this.tabControlHistory.TabIndex = 3;
            this.tabControlHistory.SelectedIndexChanged += new System.EventHandler(this.TabControlHistory_SelectedIndexChanged);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.tabControlHistory);
            this.Name = "FormHistory";
            this.Text = "AoE2.net Desktop - History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHistory_FormClosing);
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.Shown += new System.EventHandler(this.FormHistory_ShownAsync);
            this.contextMenuStripMatchedPlayers.ResumeLayout(false);
            this.tabPageMatches.ResumeLayout(false);
            this.tabPageMatches.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPageStatistics.ResumeLayout(false);
            this.splitContainerRate.Panel1.ResumeLayout(false);
            this.splitContainerRate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRate)).EndInit();
            this.splitContainerRate.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControlHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMatchedPlayers;
        private System.Windows.Forms.ToolStripMenuItem openAoE2NetProfileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageMatches;
        private System.Windows.Forms.Label labelComboBoxLeaderboard;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListView listViewMatchHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.ComboBox comboBoxDataSource;
        private ScottPlot.FormsPlot formsPlotWinRate;
        private System.Windows.Forms.ComboBox comboBoxLeaderboard;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.SplitContainer splitContainerRate;
        private ScottPlot.FormsPlot formsPlotRate1v1;
        private ScottPlot.FormsPlot formsPlotRateTeam;
        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader columnHeaderLeaderboard;
        private System.Windows.Forms.ColumnHeader columnHeaderRank;
        private System.Windows.Forms.ColumnHeader columnHeaderRating;
        private System.Windows.Forms.ColumnHeader columnHeaderHighestRating;
        private System.Windows.Forms.ColumnHeader columnHeaderGames;
        private System.Windows.Forms.ColumnHeader columnHeaderWinRate;
        private System.Windows.Forms.ColumnHeader columnHeaderWins;
        private System.Windows.Forms.ColumnHeader columnHeaderLosses;
        private System.Windows.Forms.ColumnHeader columnHeaderDrop;
        private System.Windows.Forms.ColumnHeader columnHeaderStreak;
        private System.Windows.Forms.ColumnHeader columnHeaderHighestStreak;
        private System.Windows.Forms.ColumnHeader columnHeaderLowestStreak;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listViewMatchedPlayers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderRate1v1;
        private System.Windows.Forms.ColumnHeader columnHeaderRateTeam;
        private System.Windows.Forms.ColumnHeader columnHeaderTeamGameCount;
        private System.Windows.Forms.ColumnHeader columnHeaderAllyGames;
        private System.Windows.Forms.ColumnHeader columnHeaderEnemyGames;
        private System.Windows.Forms.ColumnHeader columnHeader1v1GameCount;
        private System.Windows.Forms.ColumnHeader columnHeaderLastDate;
        private ScottPlot.FormsPlot formsPlotCountry;
        private System.Windows.Forms.TabControl tabControlHistory;
    }
}