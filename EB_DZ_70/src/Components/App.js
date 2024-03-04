import React from 'react'
import { Wrapper } from './Wrapper/Wrapper'
import { Header } from './Header/Header'
import { Greeting } from './Greeting/Greeting'
import { Advantages } from './Advantages/Advantages'
import { AboutUs } from './AboutUs/AboutUs'
import { Services } from './Services/Services'
import { ContactCompany } from './ContactCompany/ContactCompany'
import { Projects } from './Projects/Projects'
import { Form } from './Form/Form'
import { Footer } from './Footer/Footer'
import { License } from './License/License'

export const App = () => {

  return (
    <div>
      <Wrapper Component={<Header/>}/>
      <Greeting/>
      <Wrapper Component={<Advantages/>}/>
      <Wrapper Component={<AboutUs/>}/>
      <Services/>
      <ContactCompany/>
      <Wrapper Component={<Projects/>}/>
      <Form/>
      <Wrapper Component={<Footer/>}/>
      <License/>
    </div>
  )
}
