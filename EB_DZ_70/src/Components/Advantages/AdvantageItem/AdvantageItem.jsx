import React from "react";


export const AdvantageItem = ({ img, title, description }) =>
{
    return (
        <div className="advantage-item">
            <img className="advantage-img" src={img}/>
            <div className="advantage-title">{title}</div>
            <div className="advantage-description">{description}</div>
        </div>
    )
}