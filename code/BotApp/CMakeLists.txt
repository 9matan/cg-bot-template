cmake_minimum_required(VERSION 3.8)

add_executable(BotApp Bot.cpp)
add_dependencies(BotApp BotCore)

target_include_directories(BotApp PRIVATE ../BotCore)