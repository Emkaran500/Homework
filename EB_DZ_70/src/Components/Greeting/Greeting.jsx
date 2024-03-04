import React from "react";
import { Wrapper } from "../Wrapper/Wrapper";
import '../../Assets/Components/greetingblock.scss'

export const Greeting = () =>
{
    return(
        <div className="background-block">
            <Wrapper Component={<div className="div-phrase">Building things is our mission.</div>}/>
        </div>
    )
}