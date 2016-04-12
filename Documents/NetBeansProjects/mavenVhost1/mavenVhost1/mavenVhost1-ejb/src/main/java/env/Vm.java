/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package env;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author HPP
 */
@Entity
@Table(name = "vm")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Vm.findAll", query = "SELECT v FROM Vm v"),
    @NamedQuery(name = "Vm.findById", query = "SELECT v FROM Vm v WHERE v.id = :id"),
    @NamedQuery(name = "Vm.findByVmId", query = "SELECT v FROM Vm v WHERE v.vmId = :vmId"),
    @NamedQuery(name = "Vm.findByName", query = "SELECT v FROM Vm v WHERE v.name = :name"),
    @NamedQuery(name = "Vm.findByDescription", query = "SELECT v FROM Vm v WHERE v.description = :description"),
    @NamedQuery(name = "Vm.findByOs", query = "SELECT v FROM Vm v WHERE v.os = :os"),
    @NamedQuery(name = "Vm.findByRam", query = "SELECT v FROM Vm v WHERE v.ram = :ram"),
    @NamedQuery(name = "Vm.findByVcpus", query = "SELECT v FROM Vm v WHERE v.vcpus = :vcpus"),
    @NamedQuery(name = "Vm.findByDiskPath", query = "SELECT v FROM Vm v WHERE v.diskPath = :diskPath"),
    @NamedQuery(name = "Vm.findByGraphics", query = "SELECT v FROM Vm v WHERE v.graphics = :graphics"),
    @NamedQuery(name = "Vm.findByCdrom", query = "SELECT v FROM Vm v WHERE v.cdrom = :cdrom"),
    @NamedQuery(name = "Vm.findByNetwork", query = "SELECT v FROM Vm v WHERE v.network = :network")})
public class Vm implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "id")
    private Integer id;
    @Column(name = "vm_id")
    private Integer vmId;
    @Size(max = 50)
    @Column(name = "name")
    private String name;
    @Size(max = 50)
    @Column(name = "description")
    private String description;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "os")
    private String os;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "ram")
    private String ram;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "vcpus")
    private String vcpus;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "disk_path")
    private String diskPath;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "graphics")
    private String graphics;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "cdrom")
    private String cdrom;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 100)
    @Column(name = "network")
    private String network;

    public Vm() {
    }

    public Vm(Integer id) {
        this.id = id;
    }

    public Vm(Integer id, String os, String ram, String vcpus, String diskPath, String graphics, String cdrom, String network) {
        this.id = id;
        this.os = os;
        this.ram = ram;
        this.vcpus = vcpus;
        this.diskPath = diskPath;
        this.graphics = graphics;
        this.cdrom = cdrom;
        this.network = network;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Integer getVmId() {
        return vmId;
    }

    public void setVmId(Integer vmId) {
        this.vmId = vmId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getOs() {
        return os;
    }

    public void setOs(String os) {
        this.os = os;
    }

    public String getRam() {
        return ram;
    }

    public void setRam(String ram) {
        this.ram = ram;
    }

    public String getVcpus() {
        return vcpus;
    }

    public void setVcpus(String vcpus) {
        this.vcpus = vcpus;
    }

    public String getDiskPath() {
        return diskPath;
    }

    public void setDiskPath(String diskPath) {
        this.diskPath = diskPath;
    }

    public String getGraphics() {
        return graphics;
    }

    public void setGraphics(String graphics) {
        this.graphics = graphics;
    }

    public String getCdrom() {
        return cdrom;
    }

    public void setCdrom(String cdrom) {
        this.cdrom = cdrom;
    }

    public String getNetwork() {
        return network;
    }

    public void setNetwork(String network) {
        this.network = network;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (id != null ? id.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Vm)) {
            return false;
        }
        Vm other = (Vm) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "env.Vm[ id=" + id + " ]";
    }
    
}
