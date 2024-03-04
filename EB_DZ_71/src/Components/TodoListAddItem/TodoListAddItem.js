import React, { useContext, useState } from 'react'
import { Context } from '../TodoContextProvider/TodoContextProvider';

export const TodoListAddItem = () => {

  const context = useContext(Context);
  const todoList = context.todoList;
  const addTodo = context['addTodo'];

  const [input, setInput] = useState('');

  const formSubmit = e => {
    e.preventDefault();
    addTodo({ id: todoList.length + 1, label: input, done: false });
  }

  const inputHander = e => {
    setInput(e.target.value);
  }

  return (
    <form onSubmit={formSubmit} className='todo-list-add-form'>
      <input type='text' value={input} onChange={inputHander} />
      <button>Ок</button>
    </form>
  )
}
