cmake_minimum_required(VERSION 3.8)

add_executable(BotCore_Test main.cpp)
add_dependencies(BotCore_Test BotCore)

target_include_directories(BotCore_Test PRIVATE ../BotCore)