import { useEffect, useState } from "react";
import React from 'react';
import axios, { AxiosResponse } from 'axios';
import { ProductsAPI } from '../../env';
import { ProductsType } from '../../types/productsType';


export async function getProducts(): Promise<ProductsType[]> {
    try {
        const response = await axios.get(`${ProductsAPI}/GetProducts`);
        return response.data;
    } catch (err) {
        console.log(err);
        return [];
    }
}