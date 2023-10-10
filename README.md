# Pancake-Sales-Calculator

## Description

This application assists a pancake store in calculating sales, costs, and profits. Designed with a console-based interface, it incorporates user interactivity to tailor pancake orders, considers different pricing levels (standard and VIP), and delivers a detailed summary of sales.

## Table of Contents

- [Features](#features)
- [Functions](#functions)
- [Getting Started](#getting-started)
- [Contribution](#contribution)
- [License](#license)

## Features

- **Order Customization**: Allows users to select pancake toppings and quantities.
- **Pricing Levels**: Differentiate between standard and VIP prices.
- **Sale Summary**: Provides an end-of-sale report showing quantities of each topping used, the total sale price, cost, and profit.

## Functions

### calculateSalePrice()

- Calculates the sale price based on the toppings selected and their respective prices.
- Considers customer type (standard or VIP) for pricing adjustments.

### displaySaleSummary()

- Outputs a detailed report at the end of a sale.
- Lists the quantities of each topping used, the sale price, cost, and profit.

### getPancakeOrder()

- Captures user input for pancake toppings and quantities.
- Validates user input to ensure it's within acceptable parameters.

### calculateCost()

- Determines the cost of making the pancakes based on toppings and quantities.

### calculateProfit()

- Computes profit by subtracting the cost from the sale price.

## Getting Started

1. **Clone the repository:**
```bash
git clone [your-repository-link]
