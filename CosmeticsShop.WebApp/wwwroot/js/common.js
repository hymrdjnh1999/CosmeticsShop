﻿const makeFormatPrice = (element) => {
    const price = parseInt(element.textContent);
    const newPrice = price.toLocaleString('it-IT', { style: 'currency', currency: 'VND' })
    element.textContent = newPrice
}

const prices = document.querySelectorAll('.priceFormat')
if (prices) {
    prices.forEach(item => {
        makeFormatPrice(item)
    })
}

const redirectToUserDetail = () => {
    return location.assign('/user/detail');
}

const submitForm = (buttonQuery, formQuery) => {
    $(buttonQuery).on('click', () => $(formQuery).submit())
}