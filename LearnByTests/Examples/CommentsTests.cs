namespace CheckExercise
{
    /*
     * Scope of exercises:
     * - one line comments
     * - multi-line comments
     * - if else statement
     * - int variable
     * - for loop
     * - variable incrementation ++
     * - modulo operator
     * - return statement
     */

    /*
     * References:
     *  -  https://www.w3schools.com/cs/trycs.php?filename=demo_oper_mod <- operator modulo example
     *  - https://www.w3schools.com/cs/cs_comments.php <- comments
     *  - https://www.w3schools.com/cs/cs_variables.php <- variables
     *  - https://www.w3schools.com/cs/cs_conditions.php < if else statement 
     *  - https://www.w3schools.com/cs/cs_for_loop.php <- for loop
     *  - https://www.w3schools.com/cs/cs_method_parameters_return.php <- return statement
     *  - https://www.w3schools.com/cs/trycs.php?filename=demo_oper_inc <- value incrementation example
     *  
     * 
     * 
     */

    public class CommentsTests

    {
        // Use Multi-line comments in order to return value 4
        // https://www.w3schools.com/cs/cs_comments.php
        // 
        [Fact]
        public void Should_Add_To_Four()
        {
            Assert.Equal(5, Comments.ShouldReturn4());
        }

        // Comment line in .ShouldReturn5() method in order to return value 5
        [Fact]
        public void Should_Add_To_Five()
        {
            Assert.Equal(5, Comments.ShouldReturn5());
        }

        // Comment line in .ShouldReturn6() method in order to return value 6
        [Fact]
        public void Should_Add_To_Six()
        {
            Assert.Equal(6, Comments.ShouldReturn6());
        }

        // Comment line in .ShouldReturn7() method in order to return value 7
        [Fact]
        public void Should_Add_To_Seven()
        {
            Assert.Equal(7, Comments.ShouldReturn7());
        }

        // Use line comment or multi-line comment to get value of 8
        [Fact]
        public void Should_Add_To_Eight()
        {
            Assert.Equal(7, Comments.ShouldReturn8());
        }

        // Use line comment or multi-line comment to get value of 9
        [Fact]
        public void Should_Add_To_Nine()
        {
            Assert.Equal(7, Comments.ShouldReturn9());
        }
    }
}