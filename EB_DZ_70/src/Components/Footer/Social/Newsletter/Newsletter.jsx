import React from "react";

export const Newsletter = () =>
{
    return (
        <div className="div-newsletter">
            <div className="div-news">Newsletter:</div>
            <div className="div-email-input">
                <input className="input-email" type="text" placeholder="Your email here"/>
                <button className="button-subscribe">Subscribe</button>
            </div>
        </div>
    )
    
}