import React from 'react'
import ReactDOM from 'react-dom/client'
import { App } from './Components/App'
import { TodoContextProvider } from './Components/TodoContextProvider/TodoContextProvider'

const root = ReactDOM.createRoot(document.getElementById('root'))
root.render(
  <React.StrictMode>
    <TodoContextProvider Component={<App/>}/>
  </React.StrictMode>,
)
