cmake_minimum_required(VERSION 3.8)

set(BotPackedFilePath "${CMAKE_CURRENT_BINARY_DIR}/BotPacked.cpp")
set(PackerFilePath "${CMAKE_CURRENT_SOURCE_DIR}/packer.sh")
set(CopyScriptPath "${CMAKE_CURRENT_SOURCE_DIR}/copy_packed_file_to_wnd_host.sh")

add_custom_command(
    OUTPUT ${BotPackedFilePath}
    COMMAND ${PackerFilePath}
        ARGS ${CMAKE_SOURCE_DIR}
            ${CMAKE_CURRENT_SOURCE_DIR}/../BotApp/Bot.cpp
            ${BotPackedFilePath}
    DEPENDS BotApp ${PackerFilePath}
)

add_executable(BotApp_Packed ${BotPackedFilePath})

if(EXISTS ${CopyScriptPath})
    add_custom_command(
        TARGET BotApp_Packed POST_BUILD
        COMMAND ${CopyScriptPath}
            ARGS ${BotPackedFilePath}
    )
endif()