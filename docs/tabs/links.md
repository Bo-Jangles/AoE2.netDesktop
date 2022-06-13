---
layout: links
# multilingual page pair id, this must pair with translations of this page. (This name must be unique)
lng_pair: id_links

# publish date (used for SEO)
# if not specified, site.time will be used.
#date: 2022-03-03 12:32:00 +0000

# for override items in _data/lang/[language].yml
#title: My title
#button_name: "My button"
# for override side_and_top_nav_buttons in _data/conf/main.yml
#icon: "fa fa-bath"

# seo
# if not specified, date will be used.
#meta_modify_date: 2022-03-03 12:32:00 +0000
# check the meta_common_description in _data/lang/[language].yml
#meta_description: ""

# optional
# if you enabled image_viewer_posts you don't need to enable this. This is only if image_viewer_posts = false
#image_viewer_on: true
# if you enabled image_lazy_loader_posts you don't need to enable this. This is only if image_lazy_loader_posts = false
#image_lazy_loader_on: true
# exclude from on site search
#on_site_search_exclude: true
# exclude from search engines
#search_engine_exclude: true
# to disable this page, simply set published: false or delete this file
#published: false


# you can always move this content to _data/content/ folder
# just create new file at _data/content/links/[language].yml and move content below.
###########################################################
#                Links Page Data
###########################################################
page_data:
  main:
    header: "Links"
    info: "Your Links page description."

  # To change order of the Categories, simply change the order. (you don't need to change list order.)
  category:
    - title: "Web Service"
      type: id_webService
      color: "gray"
    - title: "Web Store"
      type: id_webStore
      color: "#F4A273"

  list:
    -
    # webService
    - type: id_webService
      title: "aoe2.net"
      url: "https://aoe2.net/"
      info: "aoe2.net is a AoE2DE readerbord and lobby browser."
    - type: id_webService
      title: "AoE2DE Technology Tree"
      url: "https://aoe2techtree.net/"
      info: "Technology Tree that we can watch in the Game."

    # webStore
    - type: id_webStore
      title: "Steam"
      url: "https://store.steampowered.com/app/813780/Age_of_Empires_II_Definitive_Edition/"
      info: "You can buy Age of Empires II Definitive Edition on this web store."
---
