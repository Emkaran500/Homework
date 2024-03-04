import React from "react";

export const ServicesItem = ({ img, text }) =>
{
    return (
        <div className="services-item">
            <img className="services-img" src={img}/>
            <hr className="services-line"/>
            <div className="services-text">{text}</div>
        </div>
    )
}