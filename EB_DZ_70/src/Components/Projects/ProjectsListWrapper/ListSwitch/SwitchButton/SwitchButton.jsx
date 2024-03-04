import React from "react";

export const SwitchButton = ({ label }) =>
{
    return (
        <button className="switch-button"><span className="button-text">{label}</span></button>
    )
}