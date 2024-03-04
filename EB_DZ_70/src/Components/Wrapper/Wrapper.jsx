import React from "react";
import '../../Assets/Components/wrapper.scss'

export const Wrapper = ({ Component }) =>
{
    return (
        <div className="div-wrapper">{Component}</div>
    )
}