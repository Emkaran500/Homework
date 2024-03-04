import React from "react";
import { ServicesList } from "./ServicesList/ServicesList";
import '../../Assets/Components/services.scss';
import { Wrapper } from "../Wrapper/Wrapper";

export const Services = () =>
{
    return (
        <div className="services-wrapper">
            <Wrapper Component={
                <div style={{backgroundColor: '#F6F8F7'}}>
                    <div className="services-title">Services</div>
                    <ServicesList/>
                </div>}
            />
        </div>
    )
}