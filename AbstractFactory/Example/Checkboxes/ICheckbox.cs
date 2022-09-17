﻿namespace AbstractFactory.Example.Checkboxes;

// Here's the base interface of another product. All products
// can interact with each other, but proper interaction is
// possible only between products of the same concrete variant.
public interface ICheckbox
{
    void Paint();
}