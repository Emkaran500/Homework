import React from "react";
import { DataList } from "./DataList/DataList";
import { Input } from "./Input/Input";
import { Wrapper } from "../Wrapper/Wrapper";
import '../../Assets/Components/form.scss';
import { SubmitButton } from "./SubmitButton/SubmitButton";
import { MessageBox } from "./MessageBox/MessageBox";

export const Form = () =>
{
    return (
        <div className="form-wrapper">
            <Wrapper Component={
            <form className="form-container" action="">
                <div className="div-form-header">What can us do for you?</div>
                <div className="div-form-description">We are ready to work on a project of any complexity, whether it’s commercial or residential.</div>
                <div className="div-form-inputs">
                    <Input type={'text'} placeholder={'Your Name*'}/>
                    <Input type={'text'} placeholder={'Email*'}/>
                    <DataList/>
                    <Input type={'text'} placeholder={'Phone'}/>
                </div>
                <MessageBox style={{width: '574px', height: '113px', resize: 'none'}} type={'text'} placeholder={'Message'}/>
                <div className="div-notification"><span className="span-star">*</span> indicates a required field</div>
                <SubmitButton/>
            </form>}
            />
        </div>
    )
}