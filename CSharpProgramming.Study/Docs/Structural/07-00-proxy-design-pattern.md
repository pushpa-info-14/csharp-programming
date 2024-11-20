# Proxy Design Pattern

## Types of Proxies:

There are three types of proxies. They are as follows.

1. **Virtual Proxy:** A virtual proxy is a placeholder for “expensive to create” objects. The real object is only created when a client first requests or accesses the object.
2. **Remote Proxy:** A remote proxy provides local representation for an object that resides in a different address space.
3. **Protection Proxy:** A protection proxy controls access to a sensitive master object. The surrogate object checks that the caller has the access permissions required before forwarding the request.