﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class EmitterStructTests : EmitterTest
{
    [Fact]
    public void StructSyntax()
    {
        var syntax = Transform(new StructSymbol(new IdentifierSymbol("Test"), StructLayout.Empty));
        Assert.IsType<StructDeclarationSyntax>(syntax);
    }

    [Fact]
    public void StructKeyword()
    {
        var syntax = Transform(new StructSymbol(new IdentifierSymbol("Test"), StructLayout.Empty)) as StructDeclarationSyntax;
        Assert.Equal("struct", syntax!.Keyword.Text);
    }

    [Fact]
    public void CorrectIdentifier()
    {
        var syntax = Transform(new StructSymbol(new IdentifierSymbol("Test"), StructLayout.Empty)) as StructDeclarationSyntax;
        Assert.Equal("Test", syntax!.Identifier.Text);
    }

    [Fact]
    public void IsOnlyPublic()
    {
        var syntax = Transform(new StructSymbol(new IdentifierSymbol("Test"), StructLayout.Empty)) as StructDeclarationSyntax;
        var @public = Assert.Single(syntax!.Modifiers);
        Assert.Equal("public", @public.Text);
    }

    [Fact]
    public void IntegrationEmptyStruct()
    {
        // Note that this test also covers trivia, which is not checked otherwise.
        Assert.Equal(@"[StructLayout(LayoutKind.Explicit)]
public struct Test
{
}
", Transform(new StructSymbol(new IdentifierSymbol("Test"), StructLayout.Empty)).ToFullString());
    }
}
