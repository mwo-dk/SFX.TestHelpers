module SFX.TestHelpers

open System
open Xunit

let isTrue (x: bool) = Assert.True(x)
let isFalse (x: bool) = Assert.False(x)

let assertSuccess() = isTrue true
let assertFail() = isTrue false

let areEqual x y = isTrue <| x.Equals(y)
let areSame x y = Assert.Same(x, y)

let isNull x = Assert.Null(x)
let isNotNull x = Assert.NotNull(x)

let isType t x = x.GetType() = t
let isGeneric (t: Type) = isTrue <| t.IsGenericType
let isInterface (t: Type) = isTrue <| t.IsInterface
let isNotInterface (t: Type) = isFalse <| t.IsInterface
let impleementsInterface t itf = 
  isInterface itf
  itf.IsAssignableFrom(t)
let extendsClass t baseType =
  isNotInterface baseType
  baseType.IsAssignableFrom(t)
let isSealed (t: Type) = t.IsSealed

let getGenericArguments (t: Type) = t.GetGenericArguments()
