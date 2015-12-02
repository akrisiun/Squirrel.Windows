call git submodule update --init --recursive
call git pull origin

@REM nuget restore
msbuild

@pause