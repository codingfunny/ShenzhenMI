/* Generated By:JJTree: Do not edit this line. ASTvalue_name.cs */

using System;

namespace parser {

public class ASTvalue_name : SimpleNode {
  public ASTvalue_name(int id) : base(id) {
  }

  public ASTvalue_name(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
}


}

