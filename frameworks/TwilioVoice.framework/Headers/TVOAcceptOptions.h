//
//  TVOAcceptOptions.h
//  TwilioVoice
//
//  Copyright © 2018 Twilio, Inc. All rights reserved.
//

#import "TVOCallOptions.h"


@class TVOCallInvite;

/**
 *  `TVOAcceptOptionsBuilder` is a builder class for `TVOAcceptOptions`.
 */
@interface TVOAcceptOptionsBuilder : TVOCallOptionsBuilder

- (null_unspecified instancetype)init __attribute__((unavailable("Use [TVOAcceptOptions optionsWithCallInvite:] or [TVOAcceptOptions optionsWithCallInvite:block:] to create a `TVOAcceptOptions` instance.")));

@end

/**
 *  `TVOAcceptOptionsBuilderBlock` allows you to construct `TVOAcceptOptions` using the builder pattern.
 *
 *  @param builder The builder
 */
typedef void (^TVOAcceptOptionsBuilderBlock)(TVOAcceptOptionsBuilder * _Nonnull builder);

/**
 *  @brief `TVOAcceptOptions` represents a custom configuration to use when accepting an incoming Call.
 */
@interface TVOAcceptOptions : TVOCallOptions

- (null_unspecified instancetype)init __attribute__((unavailable("Use [TVOAcceptOptions optionsWithCallInvite:] or [TVOAcceptOptions optionsWithCallInvite:block:] to create a `TVOAcceptOptions` instance.")));

/**
 *  @brief Creates an instance of `TVOAcceptOptions` using a `TVOCallInvite` object.
 *
 *  @param callInvite A `TVOCallInvite` object with the information to accept the incoming Call.
 *
 *  @return An instance of `TVOAcceptOptions`.
 */
+ (nonnull instancetype)optionsWithCallInvite:(nonnull TVOCallInvite *)callInvite;

/**
 *  @brief Creates an instance of `TVOAcceptOptions` using a `TVOCallInvite` object and a builder block.
 *
 *  @param callInvite A `TVOCallInvite` object with the information to accept the incoming call.
 *  @param block The builder block which will be used to configure the `TVOAcceptOptions` instance.
 *
 *  @return An instance of `TVOAcceptOptions`.
 */
+ (nonnull instancetype)optionsWithCallInvite:(nonnull TVOCallInvite *)callInvite
                                        block:(nonnull TVOAcceptOptionsBuilderBlock)block;

@end
