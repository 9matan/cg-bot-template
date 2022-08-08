@echo off
set "setup_file_name_origin=vs_wsl_setup.sh"
set "setup_file_name_converted=/tmp/vs_wsl_setup.sh.tmp"

wsl -u root apt-get install -y dos2unix
wsl -u root dos2unix -n %setup_file_name_origin% %setup_file_name_converted%
wsl -u root %setup_file_name_converted%