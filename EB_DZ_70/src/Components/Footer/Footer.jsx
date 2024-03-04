import React from "react";
import { Contacts } from "./Contacts/Contacts";
import '../../Assets/Components/footer.scss';
import { Social } from "./Social/Social";

export const Footer = () =>
{
    return (
        <div className="footer">
            <Contacts/>
            <Social/>
        </div>
    )
}