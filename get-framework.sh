carthage bootstrap
cp -r Carthage/Build/iOS/TwilioVoice.framework frameworks/

#sharpie bind --output=Carthage/bindings --namespace=Twilio.Voice.iOS --sdk=iphoneos frameworks/TwilioVoice.framework/Headers/*.h