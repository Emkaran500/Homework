import React, { createContext, useState } from "react";

export const Context = createContext();

export const TodoContextProvider = ({ Component }) =>
{
    const [todoList, setTodoList] = useState([
        { id: 1, label: 'Todo item1', done: false },
        { id: 2, label: 'Todo item2', done: false },
        { id: 3, label: 'Todo item3', done: false },
      ])

    const addTodo = (todoItem) => 
    {
        const newTodos = [...todoList, todoItem]

        setTodoList(newTodos)
    }

    const deleteTodo = (id) => 
    {
        const todoIdx = todoList.findIndex(todo => {
        return todo.id === id
        })

        const todoListCopy = [...todoList]

        const newTodoList = [
            ...todoListCopy.slice(0, todoIdx),
            ...todoListCopy.slice(todoIdx + 1),
        ]

        setTodoList(newTodoList)
    }

    const toggleDone = (id) => 
    {
        const indexTodo = todoList.findIndex(todo => {
        return todo.id === id
        })

        const newTodoItem = {
            ...todoList[indexTodo],
            done: !todoList[indexTodo].done,
        }

        const newTodoList = [
            ...todoList.slice(0, indexTodo),
            newTodoItem,
            ...todoList.slice(indexTodo + 1),
        ]

        setTodoList(newTodoList)
    }

    return (
        <Context.Provider value={{todoList, setTodoList, addTodo, deleteTodo, toggleDone}}>
            {Component}
        </Context.Provider>
    )
}