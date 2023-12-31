//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

import * as moment from 'moment';


export interface BaseDTO {
    createdBy: string;
    createdDate: moment.Moment;
    updatedBy: string;
    updatedDate: moment.Moment;
}

export interface RegisterDTO extends BaseDTO {
    username?: string | undefined;
    password?: string | undefined;
    firstname?: string | undefined;
    middlename?: string | undefined;
    lastname?: string | undefined;
    email?: string | undefined;
    phone?: string | undefined;
    address?: string | undefined;
}

export interface LoginDTO {
    userId: string;
    password?: string | undefined;
}

export interface BaseEntity {
    createdBy: string;
    createdDate: moment.Moment;
    updatedBy: string;
    updatedDate: moment.Moment;
}

export interface User extends BaseEntity {
    id: string;
    username: string;
    passwordHash?: string | undefined;
    passwordSalt?: string | undefined;
    firstName: string;
    middleName?: string | undefined;
    lastName: string;
    role: number;
    phone?: string | undefined;
    email?: string | undefined;
    address?: string | undefined;
}

export interface WeatherForecast {
    date: moment.Moment;
    temperatureC: number;
    temperatureF: number;
    summary?: string | undefined;
}

export interface FileResponse {
    data: Blob;
    status: number;
    fileName?: string;
    headers?: { [name: string]: any };
}