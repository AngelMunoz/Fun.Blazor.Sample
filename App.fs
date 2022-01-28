namespace Fun.Blazor.Sample

open FSharp.Data.Adaptive
open Fun.Blazor

module App =

  let private counter initial =
    adaptiview () {
      let! counter, setCounter = cval(initial).WithSetter()
      p () { childContent $"Count: {counter}" }

      button () {
        onclick (fun _ -> setCounter (counter + 1))
        childContent "Increment"
      }

      button () {
        onclick (fun _ -> setCounter (counter - 1))
        childContent "Decrement"
      }

      button () {
        onclick (fun _ -> setCounter (initial))
        childContent "Reset"
      }

    }

  let View () =
    article () {
      class' "app"

      childContent [
        main () {
          childContent [
            h1 () { childContent "Welcome to Fun.Blazor!" }
            section () { childContent (counter 0) }
            section () { childContent (counter 100) }

            ]
        }
        footer () {
          class' "app-footer"
          childContent "Fun.Blazor.Sample"
        }
      ]
    }
