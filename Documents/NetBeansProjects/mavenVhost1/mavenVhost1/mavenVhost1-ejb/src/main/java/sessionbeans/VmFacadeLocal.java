/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sessionbeans;

import env.Vm;
import java.util.List;
import javax.ejb.Local;

/**
 *
 * @author HPP
 */
@Local
public interface VmFacadeLocal {

    void create(Vm vm);

    void edit(Vm vm);

    void remove(Vm vm);

    Vm find(Object id);

    List<Vm> findAll();

    List<Vm> findRange(int[] range);

    int count();
    
}
