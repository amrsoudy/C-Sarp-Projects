
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _VerifierResponseVerifierResult_QNAME = new QName("http://tempuri.org/", "VerifierResult");
    private final static QName _VerifierUserName_QNAME = new QName("http://tempuri.org/", "UserName");
    private final static QName _VerifierMachineName_QNAME = new QName("http://tempuri.org/", "MachineName");
    private final static QName _VerifierMachineIP_QNAME = new QName("http://tempuri.org/", "MachineIP");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link VerifierResponse }
     * 
     */
    public VerifierResponse createVerifierResponse() {
        return new VerifierResponse();
    }

    /**
     * Create an instance of {@link Verifier }
     * 
     */
    public Verifier createVerifier() {
        return new Verifier();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "VerifierResult", scope = VerifierResponse.class)
    public JAXBElement<String> createVerifierResponseVerifierResult(String value) {
        return new JAXBElement<String>(_VerifierResponseVerifierResult_QNAME, String.class, VerifierResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "UserName", scope = Verifier.class)
    public JAXBElement<String> createVerifierUserName(String value) {
        return new JAXBElement<String>(_VerifierUserName_QNAME, String.class, Verifier.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "MachineName", scope = Verifier.class)
    public JAXBElement<String> createVerifierMachineName(String value) {
        return new JAXBElement<String>(_VerifierMachineName_QNAME, String.class, Verifier.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "MachineIP", scope = Verifier.class)
    public JAXBElement<String> createVerifierMachineIP(String value) {
        return new JAXBElement<String>(_VerifierMachineIP_QNAME, String.class, Verifier.class, value);
    }

}
