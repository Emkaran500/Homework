import React, { useContext } from 'react'
import { Context } from '../TodoContextProvider/TodoContextProvider'

export const TodoListItem = ({ label, id, done }) => {
  const context = useContext(Context);

  const deleteTodo = context['deleteTodo'];
  const toggleDone = context['toggleDone'];
  
  const deleteTodoHandler = () => {
    deleteTodo(id)
  }
  
  return (
    <li className='todo-item'>
      <span
        style={{
          color: done ? 'red' : '',
        }}
      >
        {label}
      </span>{' '}
      <button
        onClick={() => {
          toggleDone(id)
        }}
      >
        {done.toString()}
      </button>{' '}
      <button onClick={deleteTodoHandler}>X</button>
    </li>
  )
}
