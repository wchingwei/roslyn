' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis.Editor.VisualBasic.KeywordHighlighting

Namespace Microsoft.CodeAnalysis.Editor.VisualBasic.UnitTests.KeywordHighlighting
    Public Class AccessorDeclarationHighlighterTests
        Inherits AbstractVisualBasicKeywordHighlighterTests

        Friend Overrides Function CreateHighlighter() As IHighlighter
            Return New AccessorDeclarationHighlighter()
        End Function

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample1_1()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    {|Cursor:[|Get|]|}
        [|Return|] 1
    [|End Get|]
    Private Set(value As Integer)
        Exit Property
    End Set
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample1_2()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    [|Get|]
        {|Cursor:[|Return|]|} 1
    [|End Get|]
    Private Set(value As Integer)
        Exit Property
    End Set
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample1_3()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    [|Get|]
        [|Return|] 1
    {|Cursor:[|End Get|]|}
    Private Set(value As Integer)
        Exit Property
    End Set
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample2_1()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    Get
        Return 1
    End Get
    {|Cursor:[|Private Set|]|}(value As Integer)
        [|Exit Property|]
    [|End Set|]
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample2_2()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    Get
        Return 1
    End Get
    [|Private Set|](value As Integer)
        {|Cursor:[|Exit Property|]|}
    [|End Set|]
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestPropertyAccessorsSample2_3()
            Test(<Text>
Class C
Public Property Foo As Integer Implements IFoo.Foo
    Get
        Return 1
    End Get
    [|Private Set|](value As Integer)
        [|Exit Property|]
    {|Cursor:[|End Set|]|}
End Property
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample1_1()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    {|Cursor:[|AddHandler|]|}(value As EventHandler)
        [|Return|]
    [|End AddHandler|]
    RemoveHandler(value As EventHandler)
    End RemoveHandler
    RaiseEvent(sender As Object, e As EventArgs)
    End RaiseEvent
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample1_2()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    [|AddHandler|](value As EventHandler)
        {|Cursor:[|Return|]|}
    [|End AddHandler|]
    RemoveHandler(value As EventHandler)
    End RemoveHandler
    RaiseEvent(sender As Object, e As EventArgs)
    End RaiseEvent
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample1_3()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    [|AddHandler|](value As EventHandler)
        [|Return|]
    {|Cursor:[|End AddHandler|]|}
    RemoveHandler(value As EventHandler)
    End RemoveHandler
    RaiseEvent(sender As Object, e As EventArgs)
    End RaiseEvent
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample2_1()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    AddHandler(value As EventHandler)
        Return
    End AddHandler
    {|Cursor:[|RemoveHandler|]|}(value As EventHandler)
    [|End RemoveHandler|]
    RaiseEvent(sender As Object, e As EventArgs)
    End RaiseEvent
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample2_2()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    AddHandler(value As EventHandler)
        Return
    End AddHandler
    [|RemoveHandler|](value As EventHandler)
    {|Cursor:[|End RemoveHandler|]|}
    RaiseEvent(sender As Object, e As EventArgs)
    End RaiseEvent
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample3_1()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    AddHandler(value As EventHandler)
        Return
    End AddHandler
    RemoveHandler(value As EventHandler)
    End RemoveHandler
    {|Cursor:[|RaiseEvent|]|}(sender As Object, e As EventArgs)
    [|End RaiseEvent|]
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestEventAccessorsSample3_2()
            Test(<Text>
Class C
Public Custom Event Foo As EventHandler Implements IFoo.Foo
    AddHandler(value As EventHandler)
        Return
    End AddHandler
    RemoveHandler(value As EventHandler)
    End RemoveHandler
    [|RaiseEvent|](sender As Object, e As EventArgs)
    {|Cursor:[|End RaiseEvent|]|}
End Event
End Class</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestProperty_IteratorExample5_1()
            Test(
<Text>
ReadOnly Iterator Property Foo As IEnumerable(Of Integer)
    {|Cursor:[|Get|]|}
        [|Yield|] 1
    [|End Get|]
End Property
</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestProperty_IteratorExample5_2()
            Test(
<Text>
ReadOnly Iterator Property Foo As IEnumerable(Of Integer)
    [|Get|]
        {|Cursor:[|Yield|]|} 1
    [|End Get|]
End Property
</Text>)
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)>
        Public Sub TestProperty_IteratorExample5_3()
            Test(
<Text>
ReadOnly Iterator Property Foo As IEnumerable(Of Integer)
    [|Get|]
        [|Yield|] 1
    {|Cursor:[|End Get|]|}
End Property
</Text>)
        End Sub

    End Class
End Namespace
