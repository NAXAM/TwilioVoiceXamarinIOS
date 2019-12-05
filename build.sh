msbuild -t:Clean,Build -p:Configuration=Release ./src/Twilio.Voice.iOS.csproj
# msbuild -t:pack ./src/Twilio.Voice.iOS.csproj
nuget pack ./twilio-voice.nuspec