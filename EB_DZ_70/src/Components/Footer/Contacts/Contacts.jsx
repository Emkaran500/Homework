import React from "react";
import { Logo } from "../../Logo/Logo";
import { ContactsNames } from "../ContactsNames/ContactsNames";
import { ContactsContents } from "./ContactsContents/ContactsContents";

export const Contacts = () =>
{
    return (
        <div>
            <div className="footer-left">
                <ContactsNames/>
                <ContactsContents/>
            </div>
            <Logo/>
        </div>
    )
}