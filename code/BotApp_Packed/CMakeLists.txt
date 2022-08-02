cmake_minimum_required(VERSION 3.8)

set(BotPackedFilePath "${CMAKE_CURRENT_BINARY_DIR}/BotPacked.cpp")
set(PackerFilePath "${CMAKE_CURRENT_SOURCE_DIR}/packer.sh")

add_custom_command(
    OUTPUT ${BotPackedFilePath}
    COMMAND ${PackerFilePath}
        ARGS ${CMAKE_SOURCE_DIR}
            ${CMAKE_CURRENT_SOURCE_DIR}/../BotApp/Bot.cpp
            ${BotPackedFilePath}
    DEPENDS BotApp ${PackerFilePath}
)

add_executable(BotApp_Packed ${BotPackedFilePath})