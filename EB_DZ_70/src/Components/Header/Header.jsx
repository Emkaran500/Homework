import React from 'react'
import { Logo } from '../Logo/Logo'
import { HeaderMenu } from './HeaderMenu/HeaderMenu'
import '../../Assets/Components/header.scss'

export const Header = () => 
{

  return (
    <div className='div-header'>
      <Logo/>
      <HeaderMenu/>
    </div>
  )
}
