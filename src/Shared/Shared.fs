namespace Shared

open System

type Todo = { Id: Guid; Description: string }

module Todo =
    let isValid (description: string) =
        String.IsNullOrWhiteSpace description |> not

    let create (description: string) =
        { Id = Guid.NewGuid()
          Description = description }

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

[<StructAttribute>]
type StructObj = {
    IntVal1: int
    DoubleVal1: double
    IntVal2: int
    DoubleVal2: double
}

type ITodosApi =
    { getTodos: unit -> Async<Todo list>
      addTodo: Todo -> Async<Todo>
      debug: StructObj -> Async<unit>}
