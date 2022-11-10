module Myriad.Typegen.Tests.Bindings

open Myriad.Typegen.Tests.Base
open Myriad.Plugins
open Fable.Core.JsInterop


[<Generator.Methods>]
type WithClass =
    static member inline classNames(value: string) = Interop.attr "className" value

    static member inline className(names: seq<string>) =
        Interop.attr "className" (String.concat " " names)

[<Generator.Methods>]
type WithClassTest =
    static member inline classNames(value: string) = Interop.attr "className" value

    static member inline className(names: seq<string>) =
        Interop.attr "className" (String.concat " " names)

[<Generator.Methods>]
type WithChildren =
    static member inline children(elements: string list) =
        unbox<Interop.inlined> (prop.children elements)


[<Generator.Included>]
type Layout =
    { Header: obj
      Content: obj
      Footer: obj }

[<Generator.Component;
  Generator.ExtendsMethods(typeof<WithClass>,
                           //
                           typeof<WithClassTest>,
                           typeof<WithChildren>)>]
type button() =
    static member inline componentImport() = (import<Layout> "Layout" "antd").Header
    static member inline disabled(value: bool) = Interop.attr "disabled" value
