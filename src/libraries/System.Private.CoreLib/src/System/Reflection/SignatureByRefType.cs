// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Reflection
{
    internal sealed class SignatureByRefType : SignatureHasElementType
    {
        internal SignatureByRefType(SignatureType elementType)
            : base(elementType)
        {
        }

        protected sealed override bool IsArrayImpl() => false;
        protected sealed override bool IsByRefImpl() => true;
        protected sealed override bool IsPointerImpl() => false;

        public sealed override bool IsSZArray => false;
        public sealed override bool IsVariableBoundArray => false;

        public sealed override int GetArrayRank() => throw new ArgumentException(SR.Argument_HasToBeArrayClass);

        protected sealed override string Suffix => "&";
    }
}
