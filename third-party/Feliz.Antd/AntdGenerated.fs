//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------



namespace Feliz

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type IButtonProperty =
    interface
    end

and ILayoutProperty =
    interface
    end

and ILayoutHeaderProperty =
    interface
    end

and ILayoutContentProperty =
    interface
    end

[<RequireQualifiedAccess>]
[<Erase>]
module Interop =
    let inline mkButtonAttr (key: string) (value: obj) : IButtonProperty = unbox (key, value)
    let inline mkLayoutAttr (key: string) (value: obj) : ILayoutProperty = unbox (key, value)
    let inline mkLayoutHeaderAttr (key: string) (value: obj) : ILayoutHeaderProperty = unbox (key, value)
    let inline mkLayoutContentAttr (key: string) (value: obj) : ILayoutContentProperty = unbox (key, value)

[<Erase>]
module AntdReact =

    type Layout =
        { Header: obj
          Content: obj
          Footer: obj }

    [<Erase>]

    type button() =
        static member inline children(elements: Fable.React.ReactElement list) =
            unbox<IButtonProperty> (prop.children elements)

        static member inline classNames(value: string) = Interop.mkButtonAttr "className" value

        static member inline className(names: seq<string>) =
            Interop.mkButtonAttr "className" (String.concat " " names)

        static member inline disabled(value: bool) = Interop.mkButtonAttr "disabled" value
        static member inline label(value: string) = Interop.mkButtonAttr "label" value

    [<Erase>]

    type layout =
        static member inline style(properties: #IStyleAttribute list) =
            Interop.mkLayoutAttr "style" (createObj !!properties)

        static member inline children(elements: Fable.React.ReactElement list) =
            unbox<ILayoutProperty> (prop.children elements)

        static member inline classNames(value: string) = Interop.mkLayoutAttr "className" value

        static member inline className(names: seq<string>) =
            Interop.mkLayoutAttr "className" (String.concat " " names)

        static member inline hasSider(value: bool) = Interop.mkLayoutAttr "hasSider" value

    [<Erase>]

    type layoutHeader =
        static member inline style(properties: #IStyleAttribute list) =
            Interop.mkLayoutHeaderAttr "style" (createObj !!properties)

        static member inline children(elements: Fable.React.ReactElement list) =
            unbox<ILayoutHeaderProperty> (prop.children elements)

        static member inline classNames(value: string) =
            Interop.mkLayoutHeaderAttr "className" value

        static member inline className(names: seq<string>) =
            Interop.mkLayoutHeaderAttr "className" (String.concat " " names)

        static member inline hasSider(value: bool) =
            Interop.mkLayoutHeaderAttr "hasSider" value

    [<Erase>]

    type layoutContent =
        static member inline style(properties: #IStyleAttribute list) =
            Interop.mkLayoutContentAttr "style" (createObj !!properties)

        static member inline children(elements: Fable.React.ReactElement list) =
            unbox<ILayoutContentProperty> (prop.children elements)

        static member inline classNames(value: string) =
            Interop.mkLayoutContentAttr "className" value

        static member inline className(names: seq<string>) =
            Interop.mkLayoutContentAttr "className" (String.concat " " names)

[<Erase>]

type Antd =
    class
        static member inline button(properties: Interop.inlined list) =
            Interop.reactApi.createElement (import "Button" "antd", createObj !!properties)

        static member inline layout(properties: Interop.inlined list) =
            Interop.reactApi.createElement (import "Layout" "antd", createObj !!properties)

        static member inline layoutHeader(properties: Interop.inlined list) =
            Interop.reactApi.createElement ((import<AntdReact.Layout> "Layout" "antd").Header, createObj !!properties)

        static member inline layoutContent(properties: Interop.inlined list) =
            Interop.reactApi.createElement ((import<AntdReact.Layout> "Layout" "antd").Content, createObj !!properties)
    end
