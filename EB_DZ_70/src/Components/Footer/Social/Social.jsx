import React from "react";
import { Newsletter } from "./Newsletter/Newsletter";
import { Socials } from "./Socials/Socials";

export const Social = () =>
{
    return (
        <div className="footer-right">
            <Newsletter/>
            <Socials/>
        </div>
    )
}