import React from "react";
import facebook from '../../../../Assets/Imgs/facebook.png'
import linkedin from '../../../../Assets/Imgs/linkedin.png'
import twitter from '../../../../Assets/Imgs/twitter.png'

export const Socials = () =>
{
    return (
        <div>
            <div className="div-news">Social:</div>
            <div className="div-socials">
                <img className="img-social" src={facebook}/>
                <img className="img-social" src={linkedin}/>
                <img className="img-social" src={twitter}/>
            </div>
        </div>
    )
}