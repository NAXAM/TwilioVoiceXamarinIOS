using System;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Runtime.InteropServices;

namespace Twilio.Voice.iOS
{
	// typedef void (^TVOAudioDeviceWorkerBlock)();
	delegate void TVOAudioDeviceWorkerBlock();

	public static class CFunctions
	{
		// extern void TVOAudioDeviceFormatChanged (TVOAudioDeviceContext _Nonnull context);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioDeviceFormatChanged(void* context);

		// extern void TVOAudioDeviceWriteCaptureData (TVOAudioDeviceContext _Nonnull context, int8_t * _Nonnull data, size_t sizeInBytes);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioDeviceWriteCaptureData(void* context, sbyte* data, nuint sizeInBytes);

		// extern void TVOAudioDeviceReadRenderData (TVOAudioDeviceContext _Nonnull context, int8_t * _Nonnull data, size_t sizeInBytes);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioDeviceReadRenderData(void* context, sbyte* data, nuint sizeInBytes);

		// extern void TVOAudioDeviceExecuteWorkerBlock (TVOAudioDeviceContext _Nonnull context, TVOAudioDeviceWorkerBlock _Nonnull block);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioDeviceExecuteWorkerBlock(void* context, TVOAudioDeviceWorkerBlock block);

		// extern void TVOAudioSessionActivated (TVOAudioDeviceContext _Nonnull context);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioSessionActivated(void* context);

		// extern void TVOAudioSessionDeactivated (TVOAudioDeviceContext _Nonnull context);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern unsafe void TVOAudioSessionDeactivated(void* context);
	}

	[Native]
	public enum TVOIceTransportPolicy : ulong
	{
		All = 0,   ///< All transports will be used.
		Relay = 1  ///< Only TURN relay transports will be used.
	}

	[Native]
	public enum TVOCallState : ulong
	{
		Connecting = 0, ///< The Call is connecting.
		Ringing,        ///< The Call is ringing.
		Connected,      ///< The Call is connected.
		Reconnecting,   ///< The Call is reconnecting.
		Disconnected    ///< The Call is disconnected.
	}

	[Native]
	public enum TVOCallFeedbackScore : ulong
	{
		NotReported = 0,
		OnePoint,
		TwoPoints,
		ThreePoints,
		FourPoints,
		FivePoints
	}

	[Native]
	public enum TVOCallFeedbackIssue : ulong
	{
		NotReported = 0,
		DroppedCall,
		AudioLatency,
		OneWayAudio,
		ChoppyAudio,
		NoisyCall,
		Echo
	}

	[Native]
	public enum TVOError : long
	{
		AccessTokenInvalidError = 20101,
		AccessTokenHeaderInvalidError = 20102,
		AccessTokenIssuerInvalidError = 20103,
		AccessTokenExpiredError = 20104,
		AccessTokenNotYetValidError = 20105,
		AccessTokenGrantsInvalidError = 20106,
		AccessTokenSignatureInvalidError = 20107,
		AuthFailureCodeError = 20151,
		ExpirationTimeExceedsMaxTimeAllowedError = 20157,
		AccessForbiddenError = 20403,
		ApplicationNotFoundError = 21218,
		ConnectionError = 31005,
		CallCancelledError = 31008,
		TransportError = 31009,
		MalformedRequestError = 31100,
		AuthorizationError = 31201,
		RegistrationError = 31301,
		UnsupportedCancelMessageError = 31302,
		BadRequestError = 31400,
		ForbiddenError = 31403,
		NotFoundError = 31404,
		RequestTimeoutError = 31408,
		ConflictError = 31409,
		UpgradeRequiredError = 31426,
		TooManyRequestsError = 31429,
		TemporarilyUnavailableError = 31480,
		CallDoesNotExistError = 31481,
		AddressIncompleteError = 31484,
		BusyHereError = 31486,
		RequestTerminatedError = 31487,
		InternalServerError = 31500,
		BadGatewayError = 31502,
		ServiceUnavailableError = 31503,
		GatewayTimeoutError = 31504,
		DNSResolutionError = 31530,
		BusyEverywhereError = 31600,
		DeclineError = 31603,
		DoesNotExistAnywhereError = 31604,
		TokenAuthenticationRejected = 51007,
		SignalingConnectionDisconnectedError = 53001,
		MediaClientLocalDescFailedError = 53400,
		MediaServerLocalDescFailedError = 53401,
		MediaClientRemoteDescFailedError = 53402,
		MediaServerRemoteDescFailedError = 53403,
		MediaNoSupportedCodecError = 53404,
		MediaConnectionError = 53405
	}

	[Native]
	public enum TVOIceCandidatePairState : ulong
	{
		Succeeded,
		Frozen,
		Waiting,
		InProgress,
		Failed,
		Cancelled,
		Unknown
	}

	[Native]
	public enum TVOLogLevel : ulong
	{
		Off = 0,
		Fatal,
		Error,
		Warning,
		Info,
		Debug,
		Trace,
		All
	}

	[Native]
	public enum TVOLogModule : ulong
	{
		Core = 0,
		Platform,
		Signaling,
		WebRTC
	}
}
