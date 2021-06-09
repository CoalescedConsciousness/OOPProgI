# Rent-A-Car project
*Author*: Mads Søndergaard<br>
*Date*: 09/06/2021<br>
*Project Lead*: Christian Thygesen<br>

----

### Changelog:
Version 1.3.5
- Optimization:
  - [l:299] Refactored use of delegates so not-null validation is checked when the delegate is called
    - [l:307] Retained one catch entry as example of error it would otherwise produce.


---
##### History:
Version 1.3.4:

- Fixes:
  - Initialization of Brands no longer throws an exception.

- Changes:
  - Added example of Delegate

- Optimization:
  - Minor refactoring of code


Version 1.3.1:

- Replaced Struct example "Everyone" with "Brands"
- Renamed the Interface "iCRUD" to "ICRUD", added Interface to Brands.
- Refactored code to use Brands objects (specifically their name) rather than string types for the car brand identifier(s).
- Added example of enum (Farve) in Car (we're assuming the owner is a high-functioning autist who will only ever want a certain set of colours)

Version 1.3.0:

- Added example of an Interface (iCRUD) and Struct(ure) (Everyone).

  - Intention was to later make it possible to add every individual (customer, employee, etc.) to this complete list of individuals.

Version 1.2.0:

- Added new Person (abstract) class and Customer class, as well as related functionality for the latter (CRUD)
- Merged certain functions related to renting cars, so this is now also reflected in customer basis in some instances. 
