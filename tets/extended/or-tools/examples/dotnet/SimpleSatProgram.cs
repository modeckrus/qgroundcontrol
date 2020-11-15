// Copyright 2010-2018 Google LLC
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START program]
using System;
using Google.OrTools.Sat;

public class SimpleSatProgram
{
  static void Main()
  {
    // Creates the model.
    // [START model]
    CpModel model = new CpModel();
    // [END model]

    // Creates the variables.
    // [START variables]
    int num_vals = 3;

    IntVar x = model.NewIntVar(0, num_vals - 1, "x");
    IntVar y = model.NewIntVar(0, num_vals - 1, "y");
    IntVar z = model.NewIntVar(0, num_vals - 1, "z");
    // [END variables]

    // Creates the constraints.
    // [START constraints]
    model.Add(x != y);
    // [END constraints]

    // Creates a solver and solves the model.
    // [START solve]
    CpSolver solver = new CpSolver();
    CpSolverStatus status = solver.Solve(model);
    // [END solve]

    if (status == CpSolverStatus.Optimal)
    {
      Console.WriteLine("x = " + solver.Value(x));
      Console.WriteLine("y = " + solver.Value(y));
      Console.WriteLine("z = " + solver.Value(z));
    }
  }
}
// [END program]
