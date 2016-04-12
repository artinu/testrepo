/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sessionbeans;

import env.Vm;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 *
 * @author HPP
 */
@Stateless
public class VmFacade extends AbstractFacade<Vm> implements VmFacadeLocal {
    @PersistenceContext(unitName = "local.mavenVhost1_mavenVhost1-ejb_ejb_1.0-SNAPSHOTPU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public VmFacade() {
        super(Vm.class);
    }
    
}
