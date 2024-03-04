import React from 'react'
import { TodoListHeader } from './TodoHeader/TodoHeader'
import { TodoListAddItem } from './TodoListAddItem/TodoListAddItem'
import { TodoList } from './TodoList/TodoList'

export const App = () => {

  return (
    <div className='todo-app'>
      <TodoListHeader />
      <TodoList />
      <TodoListAddItem />
    </div>
  )
}
