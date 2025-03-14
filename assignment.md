# Assignment

## For Pass (Godkänt)

- [x] The app must have a homepage (page) with a list of products (components).
  - [x] The app must include at least 10 products.
  - [x] A product must contain the following information:
    - ID
    - Name
    - Description
    - Image URL
    - Price
- [x] Products must be displayed using Razor components on the homepage.
  - [x] These components should not display all product details but only an overview.
  - [ ] The component must include a button to add the product to a shopping cart.
  - [ ] The shopping cart must be stored in localStorage (optional for VG, not required).
- [x] A REST API must be used to access the products.
  - [x] However, product data can be hardcoded in the API.
- [x] Clicking on a product component should navigate to a product page (page) displaying all product details.
  - [ ] On this page, it should also be possible to add the product to the shopping cart.
  - [ ] It must be possible to navigate to the product page via the browser's search bar (e.g., `localhost/product/1`).
- [ ] It must be possible to navigate to the shopping cart (page) via a button/link.
  - [ ] The shopping cart page must display the contents of the cart.
  - [ ] The shopping cart page must include a form to enter address details.

### Pass - Continued

- [ ] When the form is submitted, the user should be directed to a confirmation page (page) displaying order details:
  - [ ] Purchased products
  - [ ] Name and address from the form
  - [ ] When the order is completed, the shopping cart must be emptied.
- [x] At least 2 components (excluding pages/Layout) must be used.
- [x] All data in the "Pass" scenario can be static (hardcoded).
- [ ] HTML must be used correctly and validated.
  - [ ] Semantic elements should be used where possible.
- [ ] CSS must be well-structured and contribute to GUI/UX.
  - [x] The app must be responsive and adapted for both mobile and desktop.
  - [x] No CSS framework (Bootstrap, Tailwind, etc.) may be used.
- [x] Use the Blazor Web App template.
  <!-- - [x] It is not necessary to combine different render modes. -->
  - [x] A single project in your solution is sufficient for a passing grade.

---

## For High Pass (Väl Godkänt)

- [ ] All criteria for a passing grade must be met (localStorage can be excluded).
  - [x] Blazor Web App must use both Server-side and Client-side rendering.
- [ ] At least 4 components (excluding pages/Layout) must be designed and used.
- [ ] Product quantities must be handled:
  - [ ] Products should be able to be sold out.
  - [ ] The product display component should be able to change appearance depending on whether the item is out of stock or on sale.
- [ ] On the product page, the product price should be displayed in different currencies using the API: [Exchange Rate API](https://apininjas.com/api/exchangerate).
  - [ ] The API must be used in a way that prevents end users from accessing the API key.
- [ ] A database and a REST API must be used to access the products.
  - [ ] Product data must be stored in the database (NOTE: Not exchange rates).

### High Pass - Continued

- [ ] Users must be able to register an account with a username and password.
  - [ ] Users must be able to log in using their username and password.
- [ ] The site must remember what a user has added to the cart for their next login.
- [ ] A purchase must not be completed without being logged in.
  - [ ] Information should be retrieved from the server via an HTTP request to an API endpoint.
- [x] Shared classes must be used in both the Frontend and Backend.
- [ ] The app must be divided into 3 projects, such as:
  - [x] **WebshopFrontend:** UI, pages, components.
  - [x] **WebshopBackend:** API endpoints and business logic.
  - [x] **WebshopShared:** A separate library for shared models, DTOs, and validation logic.
- [x] In the root of your project (next to the `.sln` file), there must be an `Analysis.md` file documenting and demonstrating how you used .NET Core debugging tools and logging systems to identify, analyze, and fix at least one specific bug in the application, including a short reflection on the debugging process.
- [x] Additionally, there must be an `Assignment.md` file where you copy all the criteria (Pass + High Pass) and check off each completed task.
