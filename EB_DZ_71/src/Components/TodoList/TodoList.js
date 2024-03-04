import React, { useContext } from 'react'
import { TodoListItem } from '../TodoItem/TodoItem'
import { Context } from '../TodoContextProvider/TodoContextProvider'
import './style.scss'

export const TodoList = () => {
  const context = useContext(Context);
  const todoList = context.todoList;


  return (
    <ul className='todo-list'>
      {todoList.map(({ id, label, done }) => {
        return (
          <TodoListItem
            key={id}
            label={label}
            id={id}
            done={done}
          />
        )
      })}
    </ul>
  )
}
