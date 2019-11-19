//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a T4 template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace FakeItEasy
{
    using System;
    using System.Diagnostics.CodeAnalysis;
#if FEATURE_NETCORE_REFLECTION
    using System.Reflection;
#endif
    using System.Threading.Tasks;
    using FakeItEasy.Configuration;

    public static partial class ReturnValueConfigurationExtensions
    {
        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, T4, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, T4, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, T4, T5, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, T4, T5, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, T4, T5, T6, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, T4, T5, T6, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6, T7>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, T4, T5, T6, T7, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5), call.GetArgument<T7>(6));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6, T7>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, T4, T5, T6, T7, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5), call.GetArgument<T7>(6)));
            });
        }

        /// <summary>
        /// Specifies a function used to produce a return value when the configured call is made.
        /// The function will be called each time this call is made and can return different values
        /// each time.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the return value.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument of the faked method call.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the return value.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is by design to support the fluent API.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TReturnType>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6, T7, T8>(this IReturnValueConfiguration<TReturnType> configuration, Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
                {
                    ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                    return valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5), call.GetArgument<T7>(6), call.GetArgument<T8>(7));
                });
        }

        /// <summary>
        /// Specifies a function used to produce the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/> which is returned when the configured call is made.
        /// The function will be called each time the configured call is made and can return different values each time.
        /// The <see cref="Task{T}"/> returned from the configured call will have a <see cref="Task.Status"/> of <see cref="TaskStatus.RanToCompletion"/>.
        /// </summary>
        /// <typeparam name="TReturnType">The type of the result produced by the <see cref="Task{T}"/>.</typeparam>
        /// <typeparam name="T1">The type of the first argument of the faked method call.</typeparam>
        /// <typeparam name="T2">The type of the second argument of the faked method call.</typeparam>
        /// <typeparam name="T3">The type of the third argument of the faked method call.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument of the faked method call.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument of the faked method call.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument of the faked method call.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument of the faked method call.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument of the faked method call.</typeparam>
        /// <param name="configuration">The configuration to extend.</param>
        /// <param name="valueProducer">A function that produces the <see cref="Task{T}.Result"/> of the <see cref="Task{T}"/>.</param>
        /// <returns>The configuration object.</returns>
        /// <exception cref="FakeConfigurationException">The signatures of the faked method and the <paramref name="valueProducer"/> do not match.</exception>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Necessary to support special handling of Task<T> return values.")]
        public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TReturnType>>>
            ReturnsLazily<TReturnType, T1, T2, T3, T4, T5, T6, T7, T8>(this IReturnValueConfiguration<Task<TReturnType>> configuration, Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturnType> valueProducer)
        {
            Guard.AgainstNull(configuration, nameof(configuration));
            Guard.AgainstNull(valueProducer, nameof(valueProducer));

            return configuration.ReturnsLazily(call =>
            {
                ValueProducerSignatureHelper.AssertThatValueProducerSignatureSatisfiesCallSignature(call.Method, valueProducer.GetMethodInfo(), NameOfReturnsLazilyFeature);

                return TaskHelper.FromResult(valueProducer(call.GetArgument<T1>(0), call.GetArgument<T2>(1), call.GetArgument<T3>(2), call.GetArgument<T4>(3), call.GetArgument<T5>(4), call.GetArgument<T6>(5), call.GetArgument<T7>(6), call.GetArgument<T8>(7)));
            });
        }

    }
}