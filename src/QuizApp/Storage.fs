module Storage

open Domain

let saveStateAsync (state: AppState) : Async<unit> = async { return () }
let loadState (fallback: AppState) : AppState = fallback
