import React from "react";
import { Call } from "./Call/Call";
import { Consult } from "./Consult/Consult";
import { Wrapper } from "../Wrapper/Wrapper";
import '../../Assets/Components/contactcompany.scss';

export const ContactCompany = () =>
{
    return (
        <div className="contact-wrapper">
            <Wrapper Component={
            <div style={{backgroundColor: 'transparent', display: 'flex', justifyContent: 'space-between', alignItems: 'center'}}>
                <Call/>
                <Consult/>
            </div>}/>
        </div>
    )
}