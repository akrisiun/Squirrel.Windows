git submodule update --init --recursive
git pull origin

nuget restore
msbuild

@pause