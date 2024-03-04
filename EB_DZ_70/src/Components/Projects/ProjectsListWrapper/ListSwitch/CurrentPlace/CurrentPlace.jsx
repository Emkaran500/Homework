import React from "react";
import fullCircle from '../../../../../Assets/Imgs/full_circle.png';
import emptyCircle from '../../../../../Assets/Imgs/empty_circle.png';

export const CurrentPlace = () =>
{
    return (
        <div className="current-wrapper">
            <img src={fullCircle}/>
            <img src={emptyCircle}/>
            <img src={emptyCircle}/>
            <img src={emptyCircle}/>
            <img src={emptyCircle}/>
        </div>
    )
}