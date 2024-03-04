import React from 'react'

export const TodoListHeader = () => {
  const style = {
    fontSize: '20px',
    color: 'red',
  }

  return (
    <h1 className='todo-list-header' style={style}>
      Todo List Header
    </h1>
  )
}
