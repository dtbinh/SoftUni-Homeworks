<!DOCTYPE >
<html>
    <head>
        <title>5. Numbers from 1 to N</title>
    </head>
    <body>
        <form>
            Number: <input type="text" name="num" />
            <input type="submit">
        </form>
        <?php
            if (isset($_GET['num'])) {
                $n1 = intval($_GET['num']);

                for ($i = 1; $i <= $n1; $i++){
                    if ($i < $n1){
                        echo $i . " ";
                    } else if ($i == $n1) {
                        echo $i;
                    }
                }
            }
        ?>
    </body>
</html>